import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { Homework } from 'src/app/models/Homework';
import { environment } from 'src/environments/environment';
import { map, tap, catchError } from 'rxjs/operators';
import { HomeworksEndpoints } from '../endpoints';

@Injectable()
export class HomeworksService {
  private BASE_URL: string = environment.BASE_URL;

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
      .get<Homework[]>(
        `${this.BASE_URL}${HomeworksEndpoints.GET_HOMEWORKS}`,
        options
      )
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
