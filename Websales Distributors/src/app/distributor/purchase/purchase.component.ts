import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { cartService } from 'src/app/cartService';
import { DistributorService } from 'src/app/DistributorService';

@Component({
  selector: 'app-purchase',
  templateUrl: './purchase.component.html',
  styleUrls: ['./purchase.component.css']
})
export class PurchaseComponent {
  product:any=[];
  products:any=[];
  quantity:any;
  //public grandTotal !:number;
  public grandTotal !:number;
  price: any;
   total:any;
  constructor(private route:Router,private cart:cartService,private api:DistributorService){}

  ngOnInit(): void {
   
    //   this.api.getProducts().subscribe(res=>{
    //     this.products=res;  
    //  });
    
   
  //  this.products.foreach
  //  {
  //    ((a:any)=>{
  //    Object.assign(a,{quantity:1,total:a.price});
  //    });
  //  }

    this.cart.getproducts().subscribe((res: any)=>{
      this.product=res;
      this.grandTotal=this.cart.getTotalPrice();

    });
    
  }
 
  shopnow(){
    this.route.navigate(['hom'])
  }
 removeitem(item:any){
    this.cart.removecartitem(item);
 }
//  emptycart(){
//   this.cart.removeAllcart();
//  }
 purchasemore(){
  this.route.navigate(['hom'])
 }
 payment(){
  this.route.navigate(['checkout'])
 }
}
