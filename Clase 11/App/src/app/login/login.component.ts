import { Component, OnInit } from '@angular/core';
import { UsersService } from '../core/http-services/users/users.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css'],
})
export class LoginComponent implements OnInit {
  constructor(private _userService: UsersService) {}

  ngOnInit(): void {}

  isLoggedIn(): boolean {
    return localStorage.getItem('userInfo') != null;
  }

  login() {
    this._userService.login().subscribe((userInfo) => {
      console.log('userInfo', userInfo);
      this.saveUserInfo(
        JSON.stringify({ email: userInfo.email, token: userInfo.token })
      );
    });
  }

  logout() {
    localStorage.removeItem('userInfo');
  }

  private saveUserInfo(userInfo: string): void {
    localStorage.setItem('userInfo', userInfo);
  }
}
