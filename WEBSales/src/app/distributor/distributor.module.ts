import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HeaderComponent } from './header/header.component';
import { ProfileComponent } from './profile/profile.component';
import { CartComponent } from './cart/cart.component';
import { HomeComponent } from './home/home.component';
import { HomeCatalogComponent } from './home-catalog/home-catalog.component';
import { ProductsComponent } from './products/products.component';
import { PurchaseComponent } from './purchase/purchase.component';
import { PaymentComponent } from './payment/payment.component';
import { AddressComponent } from './address/address.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { BankdetailsComponent } from '../bankdetails/bankdetails.component';
import { CheckoutComponent } from './checkout/checkout.component';
import { PlaceorderComponent } from './placeorder/placeorder.component';





@NgModule({
  declarations: [
    BankdetailsComponent,
    HeaderComponent,
    ProfileComponent,
    CartComponent,
    HomeComponent,
    HomeCatalogComponent,
    ProductsComponent,
    PurchaseComponent,
    PaymentComponent,
    AddressComponent,
    CheckoutComponent,
    PlaceorderComponent
  ],
  imports: [
    CommonModule,
    FormsModule,
    ReactiveFormsModule
  
  ],
  exports:[ HeaderComponent,
    HomeComponent],
})
export class DistributorModule { }
