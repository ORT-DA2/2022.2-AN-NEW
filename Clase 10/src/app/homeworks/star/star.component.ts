import {Component, EventEmitter, Input, OnChanges, OnInit, Output} from '@angular/core';

@Component({
  selector: 'app-star',
  templateUrl: './star.component.html',
  styleUrls: ['./star.component.css']
})
export class StarComponent implements OnChanges {

  starWidth : number =5;
  @Input() rating:number = 0;
  @Output() ratingClicked:EventEmitter<string> = new EventEmitter<string>();
  constructor() { }

  ngOnChanges():void {
    this.starWidth = this.rating * 86/5
  }

  onClick():void{
    this.ratingClicked.emit(`El raiting es ${this.rating}!`)
  }

}
