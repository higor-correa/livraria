import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';
import { RouterModule } from '@angular/router';
import { AppComponent } from './components/app/app.component';
import { LivroCreateComponent } from './components/livro-create/livro.create.component';
import { LivroEditComponent } from './components/livro-edit/livro.edit.component';
import { LivroComponent } from './components/livro/livro.component';
import { NavMenuComponent } from './components/navmenu/navmenu.component';


@NgModule({
    declarations: [
        LivroComponent,
        NavMenuComponent,
        LivroCreateComponent,
        AppComponent
    ],
    imports: [
        CommonModule,
        HttpModule,
        ReactiveFormsModule,
        FormsModule,
        RouterModule.forRoot([
            { path: '', redirectTo: 'livro', pathMatch: 'full' },
            { path: 'livro', component: LivroComponent },
            { path: 'livro/new', component: LivroCreateComponent },
            { path: 'livro/edit/:id', component: LivroCreateComponent },
            { path: '**', redirectTo: 'livro' }
        ])
    ]
})
export class AppModuleShared {
}
