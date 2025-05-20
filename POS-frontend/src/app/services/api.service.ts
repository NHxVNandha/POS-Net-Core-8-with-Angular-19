import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';  // IMPORT HttpClient yang benar
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class ApiService {
  private baseUrl = 'http://localhost:7225/api';

  constructor(private http: HttpClient) { }  // INJEKSI HttpClient di sini

  getProducts(): Observable<any> {
    return this.http.get(`${this.baseUrl}/products`);
  }

  // metode lain...
}
