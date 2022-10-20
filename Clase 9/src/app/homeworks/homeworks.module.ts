import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import {HomeworksListComponent} from "./homeworks-list/homeworks-list.component";
import {FormsModule} from "@angular/forms";
import { HomeworksFilterPipe } from './homeworks-filter.pipe';
import {HomeworksService} from "../services/homeworks.service";
import {HttpClientModule} from "@angular/common/http";

@NgModule({
  declarations: [
    HomeworksListComponent,
    HomeworksFilterPipe],
  exports:[HomeworksListComponent],
  imports: [
    CommonModule,
    FormsModule,
    HttpClientModule

  ],
  providers:[HomeworksService]

})
export class HomeworksModule { }
