import { Component } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import { bootstrapApplication } from '@angular/platform-browser';
import { HttpClient } from '@angular/common/http';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [CommonModule, HttpClientModule], // <-- import HttpClientModule di sini
  template: `
    <h1>Products</h1>
    <ul>
      <li *ngFor="let product of products">{{ product.name }}</li>
    </ul>
  `,
})
export class AppComponent {
  products: any[] = [];

  constructor(private http: HttpClient) {
    this.loadProducts();
  }

  loadProducts() {
    this.http.get<any[]>('https://localhost:5001/api/product').subscribe({
      next: (data) => (this.products = data),
      error: (err) => console.error('Error loading products', err),
    });
  }
}
