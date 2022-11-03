import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { Homework } from 'src/app/models/Homework';
import { map, tap, catchError } from 'rxjs/operators';
import { HomeworksEndpoints } from '../endpoints';

@Injectable()
export class HomeworksService {
  constructor(private _httpService: HttpClient) {}

  getBasicOptions() {
    const myHeaders = new HttpHeaders();
    myHeaders.append('Accept', 'application/json');
    let options = {
      headers: myHeaders,
    };
    return options;
  }

  getHomeworks(): Observable<Homework[]> {
    let options = this.getBasicOptions();
    return this._httpService
      .get<Homework[]>(HomeworksEndpoints.GET_HOMEWORKS, options)
      .pipe(
        map((data) => <Homework[]>data),
        tap((data) =>
          console.log('Los datos que obtuvimos fueron: ' + JSON.stringify(data))
        ),
        catchError(this.handleError)
      );
  }

  private handleError(error: Response) {
    console.error(error);
    return throwError((error?.json && error.json()) || 'Server error');
  }
}
