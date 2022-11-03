import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { UsersService } from '../core/http-services/users/users.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css'],
})
export class LoginComponent implements OnInit {
  constructor(
    private _userService: UsersService,
    private _route: ActivatedRoute,
    private _router: Router
  ) {}

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
      let urlToGo;
      this._route?.queryParams.forEach((value: any) => {
        if (value?.returnUrl) {
          urlToGo = value?.returnUrl;
        }
      });
      if (urlToGo) {
        this._router.navigate([urlToGo]);
      }
    });
  }

  logout() {
    localStorage.removeItem('userInfo');
  }

  private saveUserInfo(userInfo: string): void {
    localStorage.setItem('userInfo', userInfo);
  }
}
