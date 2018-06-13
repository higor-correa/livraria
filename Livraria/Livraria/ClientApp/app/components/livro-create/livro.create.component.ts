import { Component, Inject } from '@angular/core';
import { Http } from '@angular/http';
import { ActivatedRoute, Router } from '@angular/router';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
    selector: 'livro-create',
    templateUrl: './livro.create.component.html'
})
export class LivroCreateComponent {
    public livro: Livro | undefined;
    private route: ActivatedRoute;
    private router: Router;
    private id: number;
    private http: Http;
    private baseUrl: string;

    constructor(route: ActivatedRoute, router: Router, formBuilder: FormBuilder, http: Http, @Inject('BASE_URL') baseUrl: string) {
        this.livro = new Livro();
        this.route = route;
        this.router = router;
        this.http = http;
        this.id = this.route.snapshot.params['id'];
        this.baseUrl = baseUrl;
        if (this.id !== undefined) {
            http.get(baseUrl + 'api/Livro/' + this.id).subscribe(result => {
                this.livro = result.json() as Livro;
            }, error => console.error(error));
        }
    }

    public salvar() {
        if (this.id !== undefined) {
            this.http.put(this.baseUrl + 'api/Livro/' + this.id, this.livro).subscribe(res => {
                this.router.navigate(['/livro']);
            }, (err) => {
                console.log(err);
            });
        } else {
            this.http.post(this.baseUrl + 'api/Livro/', this.livro).subscribe(res => {
                this.router.navigate(['/livro']);
            }, (err) => {
                console.log(err);
            });
        }
    }
}

export class Livro {
    id: number | undefined;
    nome: string | undefined;
    sinopse: string | undefined;
    autor: string | undefined;
    dataLancamento: Date | undefined;
}
