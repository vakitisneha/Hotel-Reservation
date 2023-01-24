import { Injectable } from "@angular/core";
import {HttpClient, HttpHeaders} from '@angular/common/http'

@Injectable({
    providedIn:'root'
})
export class DistributorService{
    httpoptions={
        headers:new HttpHeaders({
          'content-Type':'application/json'
        })
      }
     
    constructor(private http:HttpClient){}

    getProducts(){
        return this.http.get('https://localhost:44378/api/DistributorsProject/GetallDetails')
    }
    getaddressdetails(){
        return this.http.get('https://localhost:44378/api/DistributorsProject/GetaddressDetails')
    }
    
    saveAddress(data:any){
        return this.http.post('https://localhost:44378/api/DistributorsProject/insert',data,this.httpoptions).subscribe();
    }

    insertpaymentdetails(data:any){
        return this.http.post("https://localhost:44378/api/DistributorsProject/insertpayment",data,this.httpoptions).subscribe();
    }
}