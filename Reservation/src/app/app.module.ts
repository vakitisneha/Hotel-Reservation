import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { LoginComponent } from './login/login.component';

import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { AddComponent } from './login/add/add.component';
import { DeleteComponent } from './login/delete/delete.component';
import { EditComponent } from './login/edit/edit.component';
import {MatTableModule} from '@angular/material/table';
import { MatDialogModule } from '@angular/material/dialog';
import {MatFormFieldModule} from '@angular/material/form-field';
import {MatTooltipModule} from '@angular/material/tooltip';
import { reservationservice } from './reservationservice';
import { HttpClientModule } from '@angular/common/http';
import {MatDatepickerModule} from '@angular/material/datepicker';
import {MatPaginatorModule} from '@angular/material/paginator';
import { MatSortModule } from '@angular/material/sort';
import {MatToolbarModule} from '@angular/material/toolbar';
import{MatInputModule} from '@angular/material/input';

@NgModule({
  declarations: [
    AppComponent, LoginComponent,
    AddComponent,
    DeleteComponent,
    EditComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,BrowserModule,
    FormsModule,
    MatFormFieldModule,
    AppRoutingModule,
    HttpClientModule,
    ReactiveFormsModule,
    MatTableModule,
    MatDatepickerModule,
   MatDialogModule,
   MatTooltipModule,
    BrowserAnimationsModule,
    MatPaginatorModule,
    MatSortModule,
    MatToolbarModule,
    MatInputModule

  ],
  providers: [reservationservice],
  bootstrap: [AppComponent]
})
export class AppModule { }
