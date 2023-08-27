import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class ProductServiceService {
  url: string = 'https://localhost:7170/api/Product/';

  constructor(
    private http: HttpClient
  ) { }

  getProducts(){
    return this.http.get(this.url + 'product');
  }
}
