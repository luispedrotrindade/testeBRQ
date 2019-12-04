import { Injectable } from '@angular/core';
import { getViewData } from '@angular/core/src/render3/instructions';
import { HttpClient } from '@angular/common/http';
import { Post } from './Post';

@Injectable({
  providedIn: 'root'
})
export class ClienteService {

  constructor(private httpClient: HttpClient) {
    console.log('service is working - LARANJA !');
  }
  
  getData(){
    return this.httpClient.get<Post[]>("https://jsonplaceholder.typicode.com/posts");
  }
}
