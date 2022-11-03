import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { HomeworksModule } from './homeworks/homeworks.module';
import { HTTP_INTERCEPTORS } from '@angular/common/http';
import { APIInterceptor } from './core/interceptors/api-interceptor';

@NgModule({
  declarations: [AppComponent],
  imports: [BrowserModule, FormsModule, HomeworksModule],
  providers: [
    {
      provide: HTTP_INTERCEPTORS,
      useClass: APIInterceptor,
      multi: true,
    },
  ],
  bootstrap: [AppComponent],
})
export class AppModule {}
