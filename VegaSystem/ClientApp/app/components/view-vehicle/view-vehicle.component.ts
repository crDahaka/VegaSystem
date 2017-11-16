import { PhotoService } from './../../services/photo.service';
import { Component, OnInit, ViewEncapsulation, ElementRef, ViewChild } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { ToastyService } from 'ng2-toasty';
import { VehicleService } from '../../services/vehicle.service';

@Component({
  templateUrl: 'view-vehicle.component.html'
})
export class ViewVehicleComponent implements OnInit {

  @ViewChild('fileInput') fileInput: ElementRef;
  vehicle: any;
  vehicleId: number;
  photos: any[];

  constructor(private route: ActivatedRoute, private router: Router, private toasty: ToastyService, 
              private vehicleService: VehicleService, private photoService: PhotoService) {

    route.params.subscribe(p => {
      this.vehicleId = +p['id'];
      if (isNaN(this.vehicleId) || this.vehicleId <= 0) {
        router.navigate(['/vehicles']);
        return;
      }
    });
   }

  ngOnInit() {

    this.photoService.getPhotos(this.vehicleId).subscribe(photos => this.photos = photos);

    this.vehicleService.getVehicle(this.vehicleId)
      .subscribe(v => this.vehicle = v,
      err => {
        if (err.status == 404) {
          this.router.navigate(['/vehicles']);
          return;
        }
      });
  }

  delete() {
    if (confirm("Are you sure?")) {
      this.vehicleService.delete(this.vehicle.id).subscribe(x => { this.router.navigate(['/vehicles']) });
    }
  }

  uploadPhoto() {
    var nativeElement: HTMLInputElement = this.fileInput.nativeElement;

    //TODO:
    // Get the uploaded photo (nativeElement.files[0])
    this.photoService.upload(this.vehicleId, nativeElement.files).subscribe(photo => { this.photos.push(photo); });
  }
}
