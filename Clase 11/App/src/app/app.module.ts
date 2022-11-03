import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import {HomeworksModule} from "./homeworks/homeworks.module";
import { MenuComponent } from './menu/menu.component';

@NgModule({
    declarations: [
        AppComponent
    ],
    imports: [
        BrowserModule,
        FormsModule,
        HomeworksModule
    ],
    providers: [],
    bootstrap: [AppComponent]
})
export class AppModule { }
