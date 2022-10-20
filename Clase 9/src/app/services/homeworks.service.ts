import { Injectable } from "@angular/core";
import { HttpClient, HttpResponse, HttpRequest, HttpHeaders } from "@angular/common/http";
import { Observable, throwError } from "rxjs";
import { map, tap, catchError } from 'rxjs/operators';
import { Homework } from '../models/Homework';

@Injectable()
export class HomeworksService {

  private WEB_API_URL : string = 'http://localhost:4015/api/homeworks';

  constructor(private _httpService: HttpClient) {  }

  getHomeworks():Observable<Array<Homework>> {
    const myHeaders = new HttpHeaders();
    myHeaders.append('Accept', 'application/json');
    let options = {
      headers: myHeaders
    }

    return this._httpService.get(this.WEB_API_URL,options)
      .pipe(
        map((data) => <Array<Homework>> data),
        tap(data => console.log('Los datos que obtuvimos fueron: ' + JSON.stringify(data))),
        catchError(this.handleError)
      );
  }

  private handleError(error: Response) {
    console.error(error);
    return throwError(error.json()|| 'Server error');
  }
}
