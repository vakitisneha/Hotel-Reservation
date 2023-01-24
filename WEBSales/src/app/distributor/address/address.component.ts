import { Serializer } from '@angular/compiler';
import { Component, Inject, Input, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup } from '@angular/forms';
import { MAT_DIALOG_DATA } from '@angular/material/dialog';
import { DistributorService } from 'src/app/DistributorService';
// import { ReactiveFormsModule } from '@angular/forms';

@Component({
  selector: 'app-address',
  templateUrl: './address.component.html',
  styleUrls: ['./address.component.css']
})
export class AddressComponent implements OnInit{
  reserveForm=this.fb.group({
    FullName:[],
    MobileNumber:[],
    PinCode:[],
    FlatNo:[],
    BuildingName:[],
    Street:[],
    Village:[],
    city:[],
    states:[],
  })
  value:any;
  address:any;

  @Input() res:any;
  FullName!:string;
  MobileNumber!:number|any;
  PinCode!:number|any;
  FlatNo!:string;
  BuildingName!: string;
  Street!:string;
  Village!:string;
  city!:string;
  states!:string;
  
  
  constructor(private api:DistributorService,private fb:FormBuilder,@Inject(MAT_DIALOG_DATA) public data:any){}
  ngOnInit(): void {
 
//  this.reserveForm=new FormGroup({
//   FullName:new FormControl(''),
//   MobileNumber:new FormControl(''),
//   PinCode:new FormControl(''),
//   FlatNo:new FormControl(''),
//   BuildingName:new FormControl(''),
//   Street:new FormControl(''),
//   Village:new FormControl(''),
//   city:new FormControl(''),
//   states:new FormControl('')
// });
if(this.data){

      this.reserveForm.patchValue({
        FullName: this.data.FullName,
        MobileNumber: this.data.MobileNumber,
        PinCode: this.data.PinCode,
        FlatNo:this.data.FlatNo,
        BuildingName: this.data.BuildingName,
        Street: this.data.Street,
        Village: this.data.Village,
        city:this.data.city,
        states:this.data.states,
        
      });
    }
}
  

saveaddress(){
  console.log(Serializer);
  let ser=JSON.stringify(this.reserveForm.value);
  this.api.saveAddress(ser);
  window.location.reload();
}
onFormSubmit(){

}
}
