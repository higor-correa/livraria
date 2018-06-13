import { Component, Inject } from '@angular/core';
import { Http } from '@angular/http';
import { FormGroup } from '@angular/forms';

@Component({
    selector: 'livro',
    templateUrl: './livro.component.html'
})
export class LivroComponent {
    public livros: Livro[] | undefined;
    private http: Http;
    private baseUrl: string;

    constructor(http: Http, @Inject('BASE_URL') baseUrl: string) {
        this.livros = [];
        this.http = http;
        this.baseUrl = baseUrl;
        this.listarLivros();
    }

    public remover(id: number) {
        this.http.delete(this.baseUrl + "api/Livro/" + id).subscribe(res => {
            this.listarLivros();
        });
    }

    private listarLivros() {
        this.http.get(this.baseUrl + 'api/Livro').subscribe(result => {
            this.livros = result.json() as Livro[];
        }, error => console.error(error));
    }
}

interface Livro {
    id: number;
    nome: string;
    sinopse: string;
    autor: string;
    dataLancamento: Date;
}
