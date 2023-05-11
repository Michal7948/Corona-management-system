import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Details } from '../model/personalDetails';

@Injectable({
  providedIn: 'root'
})
export class PersonalDetailsService {
  private baseUrl = 'http://localhost:5073/api/PersonalDetail';

  idNumber_clicked: number = 0;
  personalDetailsArr: Details[] = [];
  constructor(private http: HttpClient) {}

  getAllDetails(): Observable<Details[]> {
    return this.http.get<Details[]>(this.baseUrl);
  }

  getDetailsById(id: number): Observable<any> {
    return this.http.get(`${this.baseUrl}/${id}`);
  }

  createPersonDetail(personDetail: any): Observable<any> {
    // var personDetail_json = JSON.stringify(personDetail);
    // console.log(personDetail_json);
    var httpOptions = { headers: new HttpHeaders({ 'Content-Type': 'application/json' }) };
    return this.http.post(`${this.baseUrl}`, personDetail,httpOptions);
  }



 

  change_idNumber(idNumber: number) {
    this.idNumber_clicked = idNumber;
  }

  get_idNumber() {
    return this.idNumber_clicked;
  }


}
