import { Component, OnInit } from "@angular/core";
import { Router } from "@angular/router";
import { TdLoadingService } from "@covalent/core";

import { AuthService } from "src/app/core/services/auth.service";
import { SnackbarService } from "src/app/core/services/snackbar.service";
import { AdminDataService } from "../services/admin-data.service";

@Component({
  selector: "app-login",
  templateUrl: "./login.component.html",
  styleUrls: ["./login.component.scss"]
})
export class LoginComponent implements OnInit {
  constructor(
    private router: Router,
    private auth: AuthService,
    private snackbar: SnackbarService,
    private adminData: AdminDataService,
    private _loading: TdLoadingService
  ) {}

  username: string;
  password: string;
  loading: boolean = false;

  ngOnInit() {
    // check if user has a stored token and it is still valid

    this.adminData.loggedIn(false);

    this.adminData.pageTitle("Login");
    if (this.auth.tokenNotExpired()) {
      this.adminData.loggedIn(true);
      this.router.navigate(["../admin/dashboard"]);
    }
  }

  login(): void {
    this._loading.register('loading');
    this.loading = true;
    this.auth.login(this.username, this.password).subscribe(
      result => {
        this._loading.resolve('loading');
        this.loading = false;
        if (result === true) {
          this.adminData.loggedIn(true);
          this.router.navigate(["../admin/dashboard"]);
        } else {
          // replace with correct message box
          this.snackbar.show("Sorry, something went wrong. Please try again.");
        }
      },
      (error: any) => {
        this._loading.resolve('loading');
        this.loading = false;

        if (error.status === 400) {
          this.snackbar.show(error.error.error_description);
        } else {
          this.snackbar.show("Sorry, something went wrong. Please try again.");
        }
      }
    );
  }
}
