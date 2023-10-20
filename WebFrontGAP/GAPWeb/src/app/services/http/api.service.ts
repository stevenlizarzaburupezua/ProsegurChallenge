import { Injectable } from '@angular/core';
import { HttpClient, HttpParams, HttpHeaders, HttpResponse } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from 'src/enviroments/enviroment';

@Injectable({
  providedIn: 'root'
})
export class ApiService {
  private baseUrl: string;

  constructor(private httpClient: HttpClient) {
    this.baseUrl = environment.api_url;
    // this.baseUrl = '';
  }

  private getHeaders(): HttpHeaders {
    const headers = new HttpHeaders()
      .set('Content-Type', 'application/json; charset=utf-8');
    return headers;
  }

  query(url: string, obj: any): Observable<any> {
    const paramQuery = {};

    Object.assign(paramQuery, obj);

    const params = new HttpParams({ fromObject: paramQuery });
    const headers = this.getHeaders();
    return this.httpClient.get(`${this.baseUrl}${url}`, { params, headers });
  }

  get(url: string, params: HttpParams = new HttpParams()): Observable<any> {
    const headers = this.getHeaders();
    return this.httpClient.get(`${this.baseUrl}${url}`, { params, headers });
  }

  post(url: string, data: object = {}, applyDefaultConfig: boolean = false): Observable<any> {
    if (!applyDefaultConfig) {
      const headers = this.getHeaders();
      return this.httpClient.post(`${this.baseUrl}${url}`, JSON.stringify(data), { headers });
    } else {
      return this.httpClient.post(`${this.baseUrl}${url}`, data);
    }
  }

  put(url: string, data: object = {}): Observable<any> {
    const headers = this.getHeaders();
    return this.httpClient.put(`${this.baseUrl}${url}`, JSON.stringify(data), { headers });
  }

  delete(url: string): Observable<any> {
    const headers = this.getHeaders();
    return this.httpClient.delete(`${this.baseUrl}${url}`, { headers });
  }

}
