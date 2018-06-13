import { Component, Inject } from '@angular/core';
import { Http } from '@angular/http';

@Component({
    selector: 'livro-edit',
    templateUrl: './livro.edit.component.html'
})
export class LivroEditComponent{
    public livros: Livro[] | undefined;

    constructor(http: Http, @Inject('BASE_URL') baseUrl: string) {
        this.livros = [];
        http.get(baseUrl + 'api/Livro').subscribe(result => {
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
    anoLancamento: number;
}
