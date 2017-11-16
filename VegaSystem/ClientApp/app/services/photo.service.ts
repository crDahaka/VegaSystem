import { Injectable } from '@angular/core';
import { Http, RequestOptions, Headers } from '@angular/http';

@Injectable()
export class PhotoService {

    constructor(private http: Http) { }

    getPhotos(vehicleId) {
        return this.http.get(`/api/vehicles/${vehicleId}/photos`).map(res => res.json());
    }

    upload(vehicleId, photo) {
        var formData = new FormData();
        formData.append('file', photo);

        // let headers = new Headers();
        // headers.append("Content-type","application/x-www-form-urlencoded");
        // let options = new RequestOptions({ headers: headers });

        return this.http.post(`/api/vehicles/${vehicleId}/photos`, formData).map(res => res.json());
    }
}