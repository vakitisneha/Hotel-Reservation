import { compileDeclareInjectableFromMetadata } from "@angular/compiler";
import { Injectable } from "@angular/core";
import { BehaviorSubject, Subject } from "rxjs";

@Injectable({
    providedIn:'root'
})
export class cartService{
  
    public cartitemList:any=[]
    public productList=new BehaviorSubject<any>([]);
    
    constructor(){}
    getproducts(){
       return this.productList.asObservable();
    }
    setproduct(product:any){
            this.cartitemList.push(...product);
            this.productList.next(product);
    }
    addtocart(product:any){
        this.cartitemList.push(product);
        this.productList.next(this.cartitemList);
        
        this.getTotalPrice();
        console.log(this.cartitemList)

    }
    getTotalPrice():number{
      
        let grandTotal=0;
        this.cartitemList.map((a:any)=>{
            grandTotal +=a.total;
        })
        return grandTotal;
    }
    removecartitem(product:any){
        this.cartitemList.map((a:any,index:any)=>{
            if(product.productId===a.productId){
                this.cartitemList.splice(index,1);
            }
        })
    this.productList.next(this.cartitemList);
    }
    removeAllcart(){
        this.cartitemList=[]
        this.productList.next(this.cartitemList);
    }
}


/* cartitemList:any[]=[];
    totalprice:Subject<number>=new Subject<number>();
    totalquantity:Subject<number>=new Subject<number>();
    product: any;
    productList: any;
    grandTotal: any;
    constructor(){}

    getproducts(){
           return this.productList.asObservable();
        }

    addtocart(product:any){
        let alreadyExistsCart:boolean=false;
        let existingCartItem:any=undefined;

        if(this.cartitemList.length>0){
                for(let item of this.cartitemList){
                    if(item.productId===this.product.productId){
                        existingCartItem=item;
                        break;
                    }  
                }
                alreadyExistsCart=(existingCartItem !=undefined);
        }
        if(alreadyExistsCart){
            existingCartItem.quantity++;

        }else{
            this.cartitemList.push(product);
        }
        this.getTotalPrice();
    }
         
    getTotalPrice() {
        let totalprice:number=0;
        let totalquantity:number=0;

        for(let currentcartItem of this.cartitemList){
            totalprice +=currentcartItem.quantity*currentcartItem.price;
            totalquantity +=currentcartItem.quantity;
            }
        this.grandTotal.next(totalprice);
        this.totalquantity.next(totalquantity);
        this.cartdata(totalprice,totalquantity);
    }
    cartdata(totalprice: number, totalquantity: number) {
       for(let item of this.cartitemList){
        const total=item.quantity*item.price;
       }
    }
     removecartitem(product:any){
        this.cartitemList.map((a:any,index:any)=>{
            if(product.productId===a.productId){
                this.cartitemList.splice(index,1);
            }
        })
        this.productList.next(this.cartitemList);
         */















// //  public cartitemList:any=[]
// public productList=new BehaviorSubject<any>([]);
    
// constructor(){}
// getproducts(){
//    return this.productList.asObservable();
// }
// setproduct(product:any){
//         this.cartitemList.push(...product);
//         this.productList.next(product);
// }
// addtocart(product:any){
//     this.cartitemList.push(product);
//     this.productList.next(this.cartitemList);
//     this.getTotalPrice();
//     console.log(this.cartitemList)

// }
// getTotalPrice():number{
//     let grandTotal=0;
//     this.cartitemList.map((a:any)=>{
//         grandTotal +=a.total;
//     })
//     return grandTotal;
// }
// removecartitem(product:any){
//     this.cartitemList.map((a:any,index:any)=>{
//         if(product.productId===a.productId){
//             this.cartitemList.splice(index,1);
//         }
//     })
//     this.productList.next(this.cartitemList);
// }
// removeAllcart(){
//     this.cartitemList=[]
//     this.productList.next(this.cartitemList);
// }
