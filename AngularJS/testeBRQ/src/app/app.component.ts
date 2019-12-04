import { Component } from '@angular/core';
import {ClienteService} from './cliente.service';
import {HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})

export class AppComponent {
  title = 'testeBRQ';
}
