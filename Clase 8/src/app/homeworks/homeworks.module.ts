import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import {HomeworksListComponent} from "./homeworks-list/homeworks-list.component";
import {FormsModule} from "@angular/forms";



@NgModule({
  declarations: [
    HomeworksListComponent],
  exports:[HomeworksListComponent],
  imports: [
    CommonModule,
    FormsModule
  ]

})
export class HomeworksModule { }
