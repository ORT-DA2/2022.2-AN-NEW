import { Injectable } from "@angular/core";
import { HttpClient, HttpResponse, HttpRequest, HttpHeaders } from "@angular/common/http";
import { Observable, throwError } from "rxjs";
import { map, tap, catchError } from 'rxjs/operators';
import { Homework } from '../models/Homework';
import {Exercise} from "../models/Exercise";

@Injectable()
export class HomeworksService {

  private WEB_API_URL : string = 'http://localhost:4015/api/homeworks';

  constructor(private _httpService: HttpClient) {  }

  getHomeworks():Array<Homework> {
    return [
      new Homework("1", "Una tarea", 0, new Date(),
        [new Exercise("1", "Un Problema", 0)],2),
      new Homework("2", "Otra tarea", 0, new Date(), [],4)
    ];
  }

}
