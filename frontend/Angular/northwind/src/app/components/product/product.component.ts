import { ProductService } from './../../services/product.service';
import { Component, OnDestroy, OnInit } from '@angular/core';
import { Product } from 'src/app/models/product';
import { ActivatedRoute } from '@angular/router';
import { Subject, takeUntil } from 'rxjs';

@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrls: ['./product.component.css']
})
export class ProductComponent implements OnInit, OnDestroy {

  products: Product[] = [];
  dataLoaded = false;
  destroy$ = new Subject();


  constructor(private productService: ProductService, private activatedRoute: ActivatedRoute) { } //activatedroute is a built in service in angular

  ngOnInit(): void {
    this.activatedRoute.queryParams.pipe(takeUntil(this.destroy$)).subscribe(params => {
      if (params["id"]) {
        this.getProductsByCategory(params["id"]);
      }
      else {
        this.getProducts();
      }
    })
  }

  ngOnDestroy(): void {
    this.destroy$.next(1);
    this.destroy$.complete();
  }

  getProducts() {
    this.productService.getProducts().subscribe(response => {
      this.products = response.data;
      this.dataLoaded = true;
    }) // subscribe methodu senkron çalışmayı sağlar
  }

  getProductsByCategory(categoryId: number) {
    this.productService.getProductsByCategory(categoryId).subscribe(response => {
      this.products = response.data;
      this.dataLoaded = true;
    }) // subscribe methodu senkron çalışmayı sağlar
  }
}


// JAVASCRIPT'TE CONSTRUCTORDA TANIMLANAN DEĞİŞKEN TÜM CLASSTA KULLANILABİLİR (C# AKSİNE)