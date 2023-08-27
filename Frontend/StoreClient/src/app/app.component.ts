import { Component } from '@angular/core';
import { ProductServiceService } from './services/product-service.service'
@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  title = 'StoreClient';

  products: Array<any> = [];

  show: boolean = false;

  constructor(
    private productS: ProductServiceService
  ){

    this.productS.getProducts().subscribe((data: any) => {
      console.log(data);
      this.products = data;
    });
  }


  toggle(){
    this.show = !this.show
  }

}
