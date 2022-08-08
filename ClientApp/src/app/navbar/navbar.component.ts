import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { NotificationType } from '../_common/notificationType';
import { CallNotification } from '../_models/callNotification';
import { UserDetail } from '../_models/userDetail';
import { AccountService } from '../_services/account.service';
import { SignalRService } from '../_services/signalr.service';
import { UserService } from '../_services/user.service';

@Component({
  selector: 'app-navbar',
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.css']
})
export class NavbarComponent implements OnInit {
  
  currentUsername?: string = undefined;
  isShown = false;
  callerInfo!: CallNotification;
  showCallingWindow = false;
  audio = new Audio();
  friendDetails!: UserDetail;

  constructor(
    public accountService: AccountService, 
    private _router: Router, 
    private _signalrService: SignalRService,
    private _userService: UserService
    ) { }

  ngOnInit(): void {
    this.accountService.currentUser$.subscribe(q => this.currentUsername = q?.email);
    this.handleCallNotification();
  }

  logout() {
    this.accountService.logout();
    this._router.navigateByUrl('/');
  }

  callAcceptedOrRejected(isAccepted: boolean) {
    const callResponse = isAccepted
      ? NotificationType.CallAccepted
      : NotificationType.CallRejected;
    this._signalrService
      .sendCallResponse(this.callerInfo.connectionId, callResponse)
      .then(() => {
        this.stopRingtone();
        if (!isAccepted) this.showCallingWindow = false;
      });
  }

  handleCallNotification() {
    this._signalrService.callNotification$.subscribe((response) => {
      this.callerInfo = response;
      if (
        response.notificationType == NotificationType.VideoCall ||
        response.notificationType == NotificationType.AudioCall
      ) {
        this.handleIncomingCall();
      } 
      else if (response.notificationType == NotificationType.CallCancelled) {
        this.handleCallCancelledByCaller();
      } 
    });
  }

  private handleIncomingCall(){
    this._userService.getByUsername(this.callerInfo.callerUsername).subscribe(response => {
      this.friendDetails = response;
      this.showCallingWindow = true;
        this.playCallingRingtone();
    })
  }

  private handleCallCancelledByCaller(){
    this.stopRingtone();
    this.showCallingWindow = false;
  }

  private playCallingRingtone() {
    this.audio.src = './assets/audio/ringtone.mp3';
    this.audio.load();
    this.audio.play();
  }

  private stopRingtone() {
    this.audio.pause();
  }

}
