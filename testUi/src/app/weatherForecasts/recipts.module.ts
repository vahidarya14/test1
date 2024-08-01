import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { RouterModule, Routes } from '@angular/router';

import { ReciptsListComponent } from './list/recipts-list';
import { MyReciptsComponent } from './add-edit/my_recipts-form';

import { CookieCHelper } from './coocieHelper'
import { FilterPipe } from './filterPipe';

const heroesRoutes: Routes = [
  { path: '', redirectTo: '/recipts', pathMatch: 'full' },
  { path: 'recipts', component: ReciptsListComponent },
  { path: 'my_recipts', component: MyReciptsComponent }
];


@NgModule({
  imports: [
    RouterModule.forChild(heroesRoutes),
    CommonModule,
    FormsModule
  ],
  declarations: [  ReciptsListComponent, MyReciptsComponent ,FilterPipe ],
  providers: [    CookieCHelper  ]
})
export class ReciptsModule { }
