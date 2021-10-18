﻿@Code
    Layout = "~/_SiteLayout.vbhtml"
    PageData("Title") = "Contact"
End Code

<div class="col-lg-8 mx-auto p-3 py-md-5">
    <h4 class="mb-3">Billing address</h4>
    <form class="needs-validation" novalidate>
        <div class="row g-3">
            <div class="col-sm-6">
                <label for="firstName" class="form-label">First name</label>
                <input type="text" class="form-control" id="firstName" placeholder="" value="" required>
                <div class="invalid-feedback">
                    Valid first name is required.
                </div>
            </div>

            <div class="col-sm-6">
                <label for="lastName" class="form-label">Last name</label>
                <input type="text" class="form-control" id="lastName" placeholder="" value="" required>
                <div class="invalid-feedback">
                    Valid last name is required.
                </div>
            </div>

            <div class="col-12">
                <label for="email" class="form-label">Email <span class="text-muted">(Optional)</span></label>
                <input type="email" class="form-control" id="email" placeholder="you@example.com">
                <div class="invalid-feedback">
                    Please enter a valid email address for shipping updates.
                </div>
            </div>

            <div class="col-12">
                <label for="address" class="form-label">Address</label>
                <input type="text" class="form-control" id="address" placeholder="1234 Main St" required>
                <div class="invalid-feedback">
                    Please enter your shipping address.
                </div>
            </div>
        <hr class="my-4">

        <button class="w-100 btn btn-primary btn-lg" type="submit">Continue to checkout</button>
    </form>
</div>