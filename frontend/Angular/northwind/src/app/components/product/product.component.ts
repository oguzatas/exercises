import { ProductService } from './../../services/product.service';
import { ProductResponseModel } from './../../models/productResponseModel';
import { Component, OnInit } from '@angular/core';
import { Product } from 'src/app/models/product';

@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrls: ['./product.component.css']
})
export class ProductComponent implements OnInit {

  products: Product[] = [];

  ProductResponseModel: ProductResponseModel = {
    data: this.products,
    message: "",
    success: true
  };

  constructor(private productService: ProductService) { }

  ngOnInit(): void {
    this.getProducts();
  }

  getProducts() {
    this.productService.getProducts().subscribe(response => {
      this.products = response.data;
    }) // subscribe methodu asenkron çalışmayı sağlar
  }
}


// JAVASCRIPT'TE CONSTRUCTORDA TANIMLANAN DEĞİŞKEN TÜM CLASSTA KULLANILABİLİR (C# AKSİNE)