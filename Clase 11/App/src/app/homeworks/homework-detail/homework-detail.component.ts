import { Component, OnInit } from '@angular/core';
import {Homework} from "../../models/Homework";
import {HomeworksService} from "../../services/homeworks.service";
import {ActivatedRoute, Router} from "@angular/router";

@Component({
  selector: 'app-homework-detail',
  templateUrl: './homework-detail.component.html',
  styleUrls: ['./homework-detail.component.css']
})
export class HomeworkDetailComponent implements OnInit {
   pageTitle:string= "";
   aHomework : Homework | undefined;
  constructor(private _currentRoute:ActivatedRoute,private serviceHomework:HomeworksService, private _router: Router) { }

  ngOnInit(): void {
    this.pageTitle = "Homework detail!!"
    let id = this._currentRoute.snapshot.params['id'];
    this.aHomework = this.serviceHomework.getHomeworks().find(x=>x.id===id);
  }

  onBack():void{
    this._router.navigate(['/homeworks'])
  }

}
