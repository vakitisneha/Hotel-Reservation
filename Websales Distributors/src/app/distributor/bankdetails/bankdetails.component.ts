import { Serializer } from '@angular/compiler';
import { Component } from '@angular/core';
import { DistributorService } from '../DistributorService';

@Component({
  selector: 'app-bankdetails',
  templateUrl: './bankdetails.component.html',
  styleUrls: ['./bankdetails.component.css']
})
export class BankdetailsComponent {

   bankdetails:any;
 
  constructor(private api:DistributorService){}
  insertpaymentdetails(){
    console.log(Serializer);
    let ser=JSON.stringify(this.bankdetails.value);
    this.api.insertpaymentdetails(ser);
    window.location.reload();
}
}
