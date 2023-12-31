﻿using System;
using System.Collections.Generic;

namespace AzoresGov.Healthcare.Reimbursements.Api.Features.SignIn
{
    public sealed class SignInEntityResultModel
    {
        public SignInEntityResultModel(Guid id, IReadOnlyCollection<SignInPermissionResultModel> permissions)
        {
            Id = id;
            Permissions = permissions;
        }

        public Guid Id { get; }

        public IReadOnlyCollection<SignInPermissionResultModel> Permissions { get; }
    }
}