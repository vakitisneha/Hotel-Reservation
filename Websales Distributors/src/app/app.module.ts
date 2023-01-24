import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { DistributorModule } from './distributor/distributor.module';
import { HttpClientModule } from '@angular/common/http';
import { DistributorService } from './DistributorService';
import { MatDialogModule } from '@angular/material/dialog';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';


@NgModule({
  declarations: [
    AppComponent,
    
   
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    DistributorModule ,
    HttpClientModule,
    MatDialogModule ,
    ReactiveFormsModule,
    FormsModule

  
  ],
  providers: [DistributorService],
  bootstrap: [AppComponent]
})
export class AppModule { }
