import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { CovidDetail } from '../model/covidDetails';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class CovidDetailsService {
  private baseUrl = 'http://localhost:5073/API/CovidDetail';
  idNumber_clicked: number = 0;
  covidDetailArr: CovidDetail[] = [];
  constructor(private http: HttpClient) {}

  getAllDetails(): Observable<CovidDetail[]> {
    return this.http.get<CovidDetail[]>(this.baseUrl);
  }

  getDetailsById(id: number): Observable<any> {
    return this.http.get(`${this.baseUrl}/${id}`);
  }

  createCovidDetail(covidDetails: Object): Observable<Object> {
    var httpOptions = {
      headers: new HttpHeaders({ 'Content-Type': 'application/json' }),
    };
    return this.http.post(`${this.baseUrl}`, covidDetails, httpOptions);
  }
}
