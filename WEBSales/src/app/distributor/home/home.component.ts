import { Component,OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { cartService } from 'src/app/cartService';
import { DistributorService } from 'src/app/DistributorService';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
 
  public products:any;
  
  constructor(private api:DistributorService,private cart:cartService,private route:Router){}
  ngOnInit(): void {
    this.api.getProducts().subscribe(res=>{
      this.products=res;

       this.products.forEach((a:any)=>{
         Object.assign(a,{quantity:1,total:a.price});
         });
   })
  }

  addtocart(item:any){
    this.cart.addtocart(item);
     this.route.navigate(['purchase']);
   // this.route.navigate(['cart'])
  }
  addcart(item:any){
    this.cart.addtocart(item);
  }
}

