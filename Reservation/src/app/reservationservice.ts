
 import{HttpClient, HttpHeaders} from '@angular/common/http';
 import{Injectable}from '@angular/core';
 
 
 @Injectable({
     providedIn:'root',
 })
 
 export class reservationservice{
 
   httpoptions={
     headers:new HttpHeaders({
       'content-Type':'application/json'
     })
   }
 
     constructor(private http:HttpClient){}
       getdata(){
         return this.http.get("https://localhost:44378/api/Reservation/GetallDetails")
       }
       public create(data:any){
           return this.http.post("https://localhost:44378/api/Reservation/insert",data,this.httpoptions).subscribe();
       }
       // update(val:any){
       //   return this.http.put("https://localhost:44378/api/Reservation/insert",val);
       // }
   delete(val:any){
   return this.http.delete("https://localhost:44378/api/Reservation/delete/"+val);
 } 
 }
 
 