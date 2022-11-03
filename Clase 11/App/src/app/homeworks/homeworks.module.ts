import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HomeworksListComponent } from './homeworks-list/homeworks-list.component';
import { FormsModule } from '@angular/forms';
import { HomeworksFilterPipe } from './homeworks-filter.pipe';
import { HttpClientModule } from '@angular/common/http';
import { StarComponent } from './star/star.component';
import { MenuComponent } from '../menu/menu.component';
import { RouterModule, Routes } from '@angular/router';
import { HomeworkDetailComponent } from './homework-detail/homework-detail.component';
import { HomeworksService } from '../core/http-services/homeworks/homeworks.service';
const rootes: Routes = [
  { path: 'homeworks', component: HomeworksListComponent },
  { path: 'homeworks/:id', component: HomeworkDetailComponent },
];
@NgModule({
  declarations: [
    HomeworksListComponent,
    HomeworksFilterPipe,
    StarComponent,
    MenuComponent,
    HomeworkDetailComponent,
  ],
  exports: [HomeworksListComponent, MenuComponent],
  imports: [
    CommonModule,
    FormsModule,
    HttpClientModule,
    RouterModule.forRoot(rootes),
  ],
  providers: [HomeworksService],
})
export class HomeworksModule {}
