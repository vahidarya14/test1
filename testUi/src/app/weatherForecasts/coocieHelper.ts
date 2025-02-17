import { Injectable } from '@angular/core';

@Injectable()
export class CookieCHelper {


  savedReciptCookie()  {
    let ca: Array<string> = document.cookie.split(';');
    let caLen: number = ca.length;
    let cookieName = `fav=`;
    let c: string;

    for (let i: number = 0; i < caLen; i += 1) {
      c = ca[i].replace(/^\s+/g, '');
      if (c.indexOf(cookieName) == 0) {
        return c.substring(cookieName.length, c.length);
      }
    }
    return '[]';
  }



  deleteCookie(name: string) {
    this.setCookie(name, '', -1);
  }

  setCookie(name: string, value: any, expireDays: number, path: string = '') {
    let d: Date = new Date();
    d.setTime(d.getTime() + expireDays * 24 * 60 * 60 * 1000);
    let expires: string = `expires=${d.toUTCString()}`;
    let cpath: string = path ? `; path=${path}` : '';
    document.cookie = `${name}=${JSON.stringify(value)}; ${expires}${cpath}`;
  }


}
