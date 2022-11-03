import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { HomeworksModule } from './homeworks/homeworks.module';
import { HTTP_INTERCEPTORS } from '@angular/common/http';
import { APIInterceptor } from './core/interceptors/api-interceptor';
import { LoginModule } from './login/login.module';
import { AppRoutingModule } from './app-routing.module';
import { AuthGuard } from './core/guards/auth-guards';

@NgModule({
  declarations: [AppComponent],
  imports: [
    AppRoutingModule,
    BrowserModule,
    FormsModule,
    HomeworksModule,
    LoginModule,
  ],
  providers: [
    AuthGuard,
    {
      provide: HTTP_INTERCEPTORS,
      useClass: APIInterceptor,
      multi: true,
    },
  ],
  bootstrap: [AppComponent],
})
export class AppModule {}
