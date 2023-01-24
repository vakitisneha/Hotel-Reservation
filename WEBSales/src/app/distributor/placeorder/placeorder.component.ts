import { Component,OnInit} from '@angular/core';
import { cartService } from 'src/app/cartService';

@Component({
  selector: 'app-placeorder',
  templateUrl: './placeorder.component.html',
  styleUrls: ['./placeorder.component.css']
})
export class PlaceorderComponent implements OnInit{
  product: any;
  grandTotal !: number;
  totalitem: any;
  

  constructor(private cart:cartService){}
  ngOnInit(): void {
    this.cart.getproducts().subscribe((res: any)=>{
      this.product=res;
      this.grandTotal=this.cart.getTotalPrice();

    });
 
      this.cart.getproducts().subscribe(res=>{
          this.totalitem=res.length;  
      }) ;
}
}
