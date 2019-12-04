import { Component, OnInit } from '@angular/core';
import {ClienteService} from '../cliente.service';

@Component({
  selector: 'app-cliente',
  templateUrl: './cliente.component.html',
  styleUrls: ['./cliente.component.css']
})
export class ClienteComponent implements OnInit {
posts = [];

  constructor(private clienteService: ClienteService) { 
      this.clienteService.getData().subscribe(data=> {
        this.posts = data;           
      });
  }

  ngOnInit() {

  }

  addCliente(nome,documento,endereco,cidade,complemento,pais){
    alert(pais.value);
  }

}
