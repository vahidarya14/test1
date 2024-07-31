
import { Component, OnInit } from '@angular/core';
import { CookieCHelper } from '../coocieHelper'

import { recipe } from '../recipe'
import { recipeModel } from '../recipeModel'

//import {  my_recipes } from '../mock-db';


@Component({
  selector: 'my_recipts-form',
  templateUrl: './my_recipts-form.html',
  styleUrls: ['./my_recipts-form.css']
})
export class MyReciptsComponent implements OnInit {
  public recipes: recipeModel[] = [];

  constructor(private cookieHelper: CookieCHelper) { }

  ngOnInit() {
    this.getForecasts();
  }

  getForecasts() {
    let my_recipes = JSON.parse(this.cookieHelper.getCookie('fav')) as recipe[];
    this.recipes = my_recipes.map((p, i) => ({
      id: p.id,
      name: p.name,
      desc: p.desc,
      images: p.images,
      recipes: p.recipes,
      img_index: 0,
      is_in_Favorite: my_recipes.some(x => x.id == p.id)
    }));

  }


  removeFromFavorite(recipe: recipe) {

    let my_recipes = JSON.parse(this.cookieHelper.getCookie('fav')) as recipe[];
    my_recipes = my_recipes.filter(obj => obj.id !== recipe.id);
    this.cookieHelper.setCookie('fav', my_recipes, 100);
    this.getForecasts()
  }

  title = 'all recipes';
}
