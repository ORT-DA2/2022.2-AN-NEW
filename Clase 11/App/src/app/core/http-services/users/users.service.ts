import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { UsersEndpoints } from '../endpoints';

@Injectable({
  providedIn: 'root',
})
export class UsersService {
  constructor(private _httpService: HttpClient) {}

  public login(): Observable<any> {
    return this._httpService.post<any>(UsersEndpoints.LOGIN, {
      Email: 'marcotest1@gmail.com',
      Password: '12345',
      Token: '1',
    });
  }
}
