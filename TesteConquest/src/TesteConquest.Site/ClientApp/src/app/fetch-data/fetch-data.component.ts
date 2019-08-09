import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html'
})
export class FetchDataComponent {
  public autores: Autores[];

  constructor(public http: HttpClient, @Inject('BASE_URL') public baseUrl: string) {

  }

  public getAutores(qtd) {
    this.http.get<Autores[]>(this.baseUrl + 'api/SampleData/Get?qtd='+qtd).subscribe(result => {
      this.autores = result;
    }, error => console.error(error));

  }

}



interface Autores {
  nomeFormatado: string;
}
