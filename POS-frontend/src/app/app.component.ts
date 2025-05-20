import { Component, OnInit } from '@angular/core';
import { ApiService } from './services/api.service';

@Component({
  selector: 'app-root',
  template: `
    <h1>Products List</h1>
    <ul>
      <li *ngFor="let product of products">{{ product.name }} - {{ product.price }}</li>
    </ul>
  `,
})
export class AppComponent implements OnInit {
  products: any[] = [];

  constructor(private api: ApiService) { }

  ngOnInit() {
    this.api.getProducts().subscribe({
      next: (data) => (this.products = data),
      error: (err) => console.error('Error loading products', err),
    });
  }
}
