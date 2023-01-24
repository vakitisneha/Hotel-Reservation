import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { BankdetailsComponent } from './bankdetails/bankdetails.component';
import { AddressComponent } from './distributor/address/address.component';
import { CartComponent } from './distributor/cart/cart.component';
import { CheckoutComponent } from './distributor/checkout/checkout.component';
import { HeaderComponent } from './distributor/header/header.component';
import { HomeComponent } from './distributor/home/home.component';
import { PaymentComponent } from './distributor/payment/payment.component';
import { PlaceorderComponent } from './distributor/placeorder/placeorder.component';
import { ProductsComponent } from './distributor/products/products.component';
import { ProfileComponent } from './distributor/profile/profile.component';
import { PurchaseComponent } from './distributor/purchase/purchase.component';

const routes: Routes = [
  {
    path:"",component:HeaderComponent
  },
  
  {
    path:"products",component:ProductsComponent
  },
  {
    path:"profile",component:ProfileComponent
  },
  {
    path:'purchase',component:PurchaseComponent
  },
  {
    path:"cart",component:CartComponent
  },
  {
    path:"hom", component:HomeComponent
  },
  {
    path:'payment',component:PaymentComponent
  },{
    path:'address',component:AddressComponent
  },
  {
    path:'bankdetails',component:BankdetailsComponent
  },
  {
    path:'checkout',component:CheckoutComponent
  },
  {
    path:'placeorder',component:PlaceorderComponent
  }
  
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
