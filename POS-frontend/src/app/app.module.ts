import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http'; // ✅ PENTING

import { AppComponent } from './app.component';
import { ApiService } from './services/api.service'; // Pastikan path ini benar

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule // ✅ Wajib di-import di bagian imports
  ],
  providers: [ApiService], // Ini opsional karena Angular 14+ bisa pakai providedIn: 'root'
  bootstrap: [AppComponent]
})
export class AppModule { }
