import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { RouterModule, Routes } from '@angular/router';

import { ReciptsListComponent } from './list/recipts-list';
import { MyReciptsComponent } from './add-edit/my_recipts-form';

import { CookieCHelper } from './coocieHelper'

const heroesRoutes: Routes = [
  { path: 'recipts', component: ReciptsListComponent },
  { path: 'my_recipts', component: MyReciptsComponent }
];


@NgModule({
  imports: [
    RouterModule.forChild(heroesRoutes),
    CommonModule,
    FormsModule
  ],
  declarations: [
    ReciptsListComponent,
    MyReciptsComponent
  ],
  providers: [
    CookieCHelper
  ]
})
export class ReciptsModule { }
