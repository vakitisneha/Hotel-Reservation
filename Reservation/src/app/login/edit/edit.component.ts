import { Serializer } from '@angular/compiler';
import { Component, Inject, Input } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { reservationservice } from 'src/app/reservationservice';

@Component({
  selector: 'app-edit',
  templateUrl: './edit.component.html',
  styleUrls: ['./edit.component.css']
})
export class EditComponent {
 // positionOptions: TooltipPosition[] = ['after', 'before', 'above', 'below', 'left', 'right'];
  // position = new FormControl(this.positionOptions[0]);

reserveForm:any
  masterdata: any;
  selectedHotel: any;
  insertrev: any;
  noofguests: any;
  hotelbool : boolean = true;
  
  // onSubmit(){
  //   console.warn(this.reserveForm.value);
  // }

constructor(private edit:MatDialogRef<EditComponent>,private service:reservationservice,@Inject(MAT_DIALOG_DATA) public data:any){}

@Input() res:any;
  Slno:number|any;
  Hotel!:string;
  Arrival!:string;
  Departure!:string;
  Type!: string;
  Guests!:number;
  Price!:number;

  onClose(){
    this.edit.close();
    }


ngOnInit(): void
{
 this.reserveForm=new FormGroup({
  Slno:new FormControl(''),
  Hotel:new FormControl(''),
  Arrival:new FormControl(''),
  Departure:new FormControl(''),
  Type:new FormControl(''),
  Guests:new FormControl(''),
  Price:new FormControl('')
});
if(this.data){
let Adate = this.data.Arrival.split('T');
      let Ddate = this.data.Departure.split('T');
      this.reserveForm.patchValue({
        Slno: this.data.Slno,
        Hotel: this.data.Hotel,
        Arrival: Adate[0],
        Departure: Ddate[0],
        Type: this.data.Type,
        Guests: this.data.Guests,
        Price: this.data.Price,
      });
    }
}
addList(){
  console.log(Serializer);
  let ser=JSON.stringify(this.reserveForm.value);
  this.service.create(ser);
  window.location.reload();
}
clear(){
  console.log("ok")
}
calculateprice(){
  for(var i=0;i<this.masterdata.length;i++){
    if(this.masterdata[i].hotel==this.selectedHotel){
      let Type=this.masterdata[i].type;
      this.insertrev.patchvalue({revType:Type});
    }
  }
}
getguests(){
  let a=this.clc();
}
clc(){
  for(var i=0;i<this.masterdata.length;i++){
    if(this.masterdata[i].hotel==this.selectedHotel){
      let Price=this.masterdata[i].price;
      Price=Price *this.noofguests;
      let Type=this.masterdata[i].Type;
      this.insertrev.patchvalue({Price:Price});
    }
  }
}
}
