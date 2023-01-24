import { Component, OnInit } from '@angular/core';
import {  Router } from '@angular/router';
import { cartService } from 'src/app/cartService';


@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css']
})
export class HeaderComponent implements OnInit{
  search : String ="";
  public totalitem:number=0;
  constructor(private route:Router,private cart:cartService){}
  ngOnInit(): void {
    this.cart.getproducts().subscribe(res=>{
        this.totalitem=res.length;  
    }) 
  }
 
}
