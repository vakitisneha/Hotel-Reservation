import { Component } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { Router } from '@angular/router';
import { BankdetailsComponent } from 'src/app/bankdetails/bankdetails.component';
import { DistributorService } from 'src/app/DistributorService';
import { AddressComponent } from '../address/address.component';

@Component({
  selector: 'app-checkout',
  templateUrl: './checkout.component.html',
  styleUrls: ['./checkout.component.css']
})
export class CheckoutComponent {

  address:any;
  bankdetails:any;
  constructor(private adress:MatDialog,private api:DistributorService,private route:Router){}

  ngOnInit(): void {
    this.api.getaddressdetails().subscribe(res=>{
      this.address=res;
  });}
  openaddress(){
        this.adress.open(AddressComponent,{
        height:'70%',
        width:'50%',
      }) ; 
    }
  openEdit(value:number){
       this.adress.open(AddressComponent,{
        height:"60%",
        width:"60",
        data:value
      });
    }
   continue(){
    this.route.navigate(['payment']);
   }

//   bankDetails(){
//     this.adress.open(BankdetailsComponent,{
//       height:'70%',
//       width:'50%',
//     });
//  }

//   insertpaymentdetails(){
//     console.log(Serializer);
//     let ser=JSON.stringify(this.bankdetails.value);
//     this.api.insertpaymentdetails(ser);
//     window.location.reload();
}
