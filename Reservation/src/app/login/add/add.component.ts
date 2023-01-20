import { Component, OnInit, ViewChild } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { Router } from '@angular/router';
import { reservationservice } from 'src/app/reservationservice';
import { EditComponent } from '../edit/edit.component';
import { MatPaginator } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
import { MatTableDataSource } from '@angular/material/table';
import { DeleteComponent } from '../delete/delete.component';


// export interface Reservation {
  
// //  Slno:number,
// //  Hotel:string,
// // Arrival:string,
// // Departure:string,
// // Type:number,
// // Guests:number,
// // Price:number,
// // Manage:string
// }


@Component({
  selector: 'app-add',
  templateUrl: './add.component.html',
  styleUrls: ['./add.component.css']
})
export class AddComponent implements OnInit{

  
  dataSource !: MatTableDataSource<any>;

  displayedColumns: string[] = ['Slno', 'Hotel', 'Arrival', 'Departure','Type','Guests','Price','Manage'];

 element:any;
 @ViewChild(MatPaginator) paginator!: MatPaginator;
 @ViewChild(MatSort) matSort!: MatSort;

// gets:any[]=[];
constructor(private edit:MatDialog, private res:reservationservice,private route:Router){}


ngOnInit(): void {
  this.res.getdata().subscribe((x:any)=>{
  this.dataSource = new MatTableDataSource(x)    
  console.log('response is', x);
  this.dataSource.paginator = this.paginator;

  this.dataSource.sort = this.matSort;
    });
}
filterData($event:any){
  this.dataSource.filter = $event.target.value;
}

title = 'Reservation';

openAdd(){
  this.edit.open(EditComponent,{
    height:'70%',
    width:'50%',
  }) ; 
}
openEdit(value:number){
	this.edit.open(EditComponent,{
		height:"60%",
		width:"60",
    data:value
	});

}
openDelete(value:any){
	this.edit.open(DeleteComponent,{
		height:"30%",
		width:"90",
    data:value
	});
}
logout(){
  this.route.navigate(['']);
}



}