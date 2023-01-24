import { Serializer } from '@angular/compiler';
import { Component,OnInit} from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { Router } from '@angular/router';
import { BankdetailsComponent } from 'src/app/bankdetails/bankdetails.component';
import { DistributorService } from 'src/app/DistributorService';
import { AddressComponent } from '../address/address.component';


@Component({
  selector: 'app-payment',
  templateUrl: './payment.component.html',
  styleUrls: ['./payment.component.css']
})
export class PaymentComponent implements OnInit{
  address:any;
  bankdetails:any;
  constructor(private adress:MatDialog,private api:DistributorService,private route:Router){}

  ngOnInit(): void {
    this.api.getaddressdetails().subscribe(res=>{
      this.address=res;
  });}
 
   continue(){}

  bankDetails(){
    this.adress.open(BankdetailsComponent,{
      height:'70%',
      width:'50%',
    });
  }
placeorder(){
  this.route.navigate(['placeorder']);
}
}
//   insertpaymentdetails(){
//     console.log(Serializer);
//     let ser=JSON.stringify(this.bankdetails.value);
//     this.api.insertpaymentdetails(ser);
//     window.location.reload();
// }
    

